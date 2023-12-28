using UPVTube.Entities;
using UPVTube.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.SqlServer.Server;
using System.Collections.ObjectModel;

namespace UPVTube.Services
{
    public class UPVTubeService : IUPVTubeService
    {
        private readonly IDAL dal;
        private Member currentMember;

        public UPVTubeService(IDAL dal)
        {
            this.dal = dal;
        }

        public void RemoveAllData()
        {
            dal.RemoveAllData();
        }

        public void Commit()
        {
            dal.Commit();
        }

        public void DBInitialization()
        {
            RemoveAllData();

            Subject s1 = new Subject(11555, "Ingeniería del software", "ISW");
            AddSubject(s1);
            Subject s2 = new Subject(11553, "Arquitectura e ingeniería de computadores", "AIC");
            AddSubject(s2);
            Subject s3 = new Subject(11548, "Bases de datos y sistemas de información", "BDA");
            AddSubject(s3);
            Subject s4 = new Subject(11560, "Sistemas inteligentes", "SIN");
            AddSubject(s4);

            // Añadir los 3 miembros
            //Member m1 = new Member('@gmail.com', 'FULLNAME', DateTime lastAccessDate, 'nick', 'contraseña');



            // Añadir los 4 contenidos

            Member member1 = new Member("upv.edu.es", "Juan", DateTime.Now, "juanito", "1234");
            Content c1 = new Content("https:www.ejemplo1.com/adaszc21342vxc/zdasdas", "Descripcion del video de Juan", true, "Este es un titulo aleatorio de Juan", DateTime.Now, member1);
            UploadContent(c1, new List<Subject>());
            UploadContent(c1, new List<Subject>());
            UploadContent(c1, new List<Subject>());
            UploadContent(c1, new List<Subject>());
            UploadContent(c1, new List<Subject>());
            UploadContent(c1, new List<Subject>());
            UploadContent(c1, new List<Subject>());



        }

        public void AddSubject(Subject subject)
        {
            // Restricción: No puede haber dos asignaturas con el mismo code
            if (dal.GetById<Subject>(subject.Code) == null)
            {
                // Restricción: No puede haber dos asignaturas con el mismo name
                if (!dal.GetWhere<Subject>(x => x.Name == subject.Name).Any())
                {
                    // Sólo se salva si no hay Code ni email duplicado
                    dal.Insert<Subject>(subject);
                    dal.Commit();
                }
                else
                    throw new ServiceException("Subject with name " + subject.Name + " already exists.");
            }
            else
                throw new ServiceException("Subject with code " + subject.Code + " already exists.");
        }

        // A partir de aquí los métodos para implementar los CU
        public bool Register(String email, String name, DateTime date, String nickname, String password)
        {
            Member member = new Member(email, name, date, nickname, password);
            if (dal.GetById<Member>(member.Nick) == null)
            {
                if (!dal.GetWhere<Member>(m => m.Email == member.Email).Any())
                {
                    dal.Insert<Member>(member);
                    dal.Commit();
                    return true;
                }
                else throw new ServiceException("A member with this email already exists.");
                
            }
            else throw new ServiceException("A member with this nick already exists.");
        }

        public bool Login(string nickOrEmail, string password)
        {
            if (dal.Exists<Member>(nickOrEmail))
            {
                //NOTA: las contraseñas pueden repetirse, los nicks no deben repetirse
                if (dal.GetById<Member>(nickOrEmail).Password == password)
                {
                    currentMember = dal.GetById<Member>(nickOrEmail);
                    return true;
                }
                else throw new ServiceException("Incorrect password.");
            }
            return false;
        }


        public void Logout(Member member){
            member.LastAccessDate = DateTime.Now;
            currentMember = null;
        }

        public void UploadContent(Content content, ICollection<Subject> subjects)
        {
            if (content.Title != null && content.Description != null && content.ContentURI != null && content.Owner != null)
            {
                if (content.Owner.IsTeacher()) content.Authorized = Authorized.Yes;

                else content.Authorized = Authorized.Pending;

                content.UploadDate = DateTime.Now;

                foreach (Subject subject in subjects)
                {
                    content.AddSubject(subject);
                    subject.AddContent(content);
                }

                dal.Insert<Content>(content);
            }

            else throw new ServiceException("Cannot upload content. One or more of the content's necessary parameters (title, description, ...) is empty");
        }

        public void SearchContent(DateTime from, DateTime to, string nick, string titulo, Subject subject)
        {

            List<Content> result = dal.GetAll<Content>().Where
                (content =>
                    (nick == null || content.Owner.Nick == nick) &&
                    (from == null || content.UploadDate >= from) &&
                    (to == null || content.UploadDate <= to) &&
                    (titulo == null || content.Title.Contains(titulo)) &&
                    (subject == null || content.Subjects.Contains(subject) &&
                    (content.Authorized == Authorized.Yes))
                )
                .OrderBy(content => content.UploadDate)
                .ToList();

        }

        public void ViewContent(Content content)
        {
            //Precondición: se asume que el usuario esta loggeado o registrado
            Visualization v = new Visualization(DateTime.Now, content, currentMember);
            content.AddVisualization(v);

            string contentInfo = $"Descriptive content information:\n"
                               + $"Title: {content.Title}\n"
                               + $"Creator: {content.Owner.Nick}\n"
                               + $"Description: {content.Description}\n"
                               + $"Upload Date: {content.UploadDate}\n"
                               + $"Content: {content.ContentURI}\n";

            string URI = $"URI: {content.ContentURI}";
        }

        /*
        public void EvaluateContent()
        {
            //La interfaz muestra el título, el nick del autor, la descripción, si es público, la fecha de subida y
            //las asignaturas con las que está relacionado, de los contenidos ordenados por fecha de subida
            List<Content> result = dal.GetAll<Content>().Where
                (content => content.Authorized == Authorized.Pending
                ).OrderBy(content => content.UploadDate)
                .ToList();
        */

        public void EvaluateContent(Content content, String rejectionReason) {
            Evaluation evaluation = new Evaluation(DateTime.Now, rejectionReason, currentMember, content);
            if (rejectionReason != null)
            {
                content.AddEvaluation(evaluation);
                dal.Insert<Evaluation>(evaluation);
                //es necesario hacer un content.AddEvaluation()?? -> respuesta : si

                string email = $"Email: {content.Owner.Email}\n"
                             + $"Subject: Content Evaluation\n"
                             + $"Message: {rejectionReason}\n";

            }
            else throw new ServiceException("RejectionReason is required.");
        }

        public IList<Content> SearchAllContent() {
            List<Content> resultado = new List<Content>(dal.GetAll<Content>());
            resultado = resultado.Where(content => content.Authorized == Authorized.Yes).ToList();
            return resultado;
        }

        public IList<Content> SearchAllPublicContent() {
            List<Content> resultado = new List<Content>(dal.GetAll<Content>());
            resultado = resultado.Where(content => content.IsPublic == true && content.Authorized == Authorized.Yes).ToList();
            return resultado;
        }

        public IList<Content> SearchAllPendingContent() {
            List<Content> resultado = new List<Content>(dal.GetAll<Content>());
            resultado = resultado.Where(content => content.Authorized == Authorized.Pending).ToList();
            return resultado;
        }

        public Member getMember()
        {
            return currentMember;
        }
        public IList<Subject> getAllSubjects() {
            List<Subject> resultado = new List<Subject>(dal.GetAll<Subject>());
            return resultado;
        }
    }
}