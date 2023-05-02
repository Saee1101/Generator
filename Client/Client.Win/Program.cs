using Client.RepositoryAbstracts;
using System;
using System.Windows.Forms;

namespace Client.Win
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //RepositoryAbstracts.IUsersRepository repo = new UsersRepository();
            //repo.Add(new User() { Username = "Admin", Date = DateTime.Now });
            //var test = repo.GetByUsername("Admin");
            //Application.Run(new )
            
            Framework.Cultures.InitializePersianCulture();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var container = new StructureMap.Container(new IoC.TypeRegistry());
            var splashForm = container.GetInstance<Views.SystemForms.SplashScreenForm>();
            //var splashForm = new Views.SystemForms.SplashScreenForm();
            var result= splashForm.ShowDialog();
       if (result != DialogResult.OK)
        return;
            var userRepo = container.GetInstance<IUsersRepository>();
            
            if (userRepo.Count() == 0)
            {
                userRepo.Add(new Entities.User
                {
                    Username = "Admin",
                    Date = DateTime.Now
                });
            }
           
            Application.Run(new Form1());
        }
    }
}
