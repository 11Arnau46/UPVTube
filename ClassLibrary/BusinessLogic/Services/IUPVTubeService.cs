using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPVTube.Entities;


namespace UPVTube.Services
{
    public interface IUPVTubeService
    {
        void RemoveAllData();
        void Commit();

        // Necesario para la inicialización de la BD
        void DBInitialization();
        void AddSubject(Subject subject);


        //
        // A partir de aquí los necesarios para los CU solicitados
        //

        bool Register(String email, String name, DateTime date, String nickname, String password);
        bool Login(string nick, string password);
        void Logout(Member member);
        void UploadContent(Content content, ICollection<Subject> subjects);
        void SearchContent(DateTime from, DateTime to, string nick, string titulo, Subject subject);

        // 2 métodos finales
        void ViewContent(Content content);
        void EvaluateContent(Content content, String rejectionReason);

        IList<Content> SearchAllContent();
        IList<Content> SearchAllPublicContent();
        IList<Content> SearchAllPendingContent();

        Member getMember();
        IList<Subject> getAllSubjects();


    }
}
