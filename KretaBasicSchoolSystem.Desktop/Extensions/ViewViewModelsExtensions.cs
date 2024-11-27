﻿using KretaBasicSchoolSystem.Desktop.ViewModels;
using KretaBasicSchoolSystem.Desktop.ViewModels.ControlPanel;
using KretaBasicSchoolSystem.Desktop.ViewModels.Login;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolClasses;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolGrades;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolSubjects;
using KretaBasicSchoolSystem.Desktop.ViewModels.Users;
using KretaBasicSchoolSystem.Desktop.Views;
using KretaBasicSchoolSystem.Desktop.Views.ControlPanel;
using KretaBasicSchoolSystem.Desktop.Views.Login;
using KretaBasicSchoolSystem.Desktop.Views.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.Views.SchoolClasses;
using KretaBasicSchoolSystem.Desktop.Views.SchoolGrades;
using KretaBasicSchoolSystem.Desktop.Views.SchoolSubjects;
using KretaBasicSchoolSystem.Desktop.Views.Users;
using Microsoft.Extensions.DependencyInjection;

namespace KretaDesktop.Extensions
{
    public static class ViewViewModelsExtensions
    {
        public static void ConfigureViewViewModels(this IServiceCollection services)
        {
            // MainView
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainView>(s => new MainView()
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            });

            // LoginView
            services.AddSingleton<LoginViewModel>();
            services.AddSingleton<LoginView>(s => new LoginView()
            {
                DataContext = s.GetRequiredService<LoginViewModel>()
            });

            // ControlPanel
            services.AddSingleton<ControlPanelViewModel>();
            services.AddSingleton<ControlPanelView>(s => new ControlPanelView()
            {
                DataContext = s.GetRequiredService<ControlPanelViewModel>()
            });
            // School Citizens
            services.AddSingleton<SchoolCitizensViewModel>();
            services.AddSingleton<SchoolCitizensView>(s => new SchoolCitizensView()
            {
                DataContext = s.GetRequiredService<SchoolCitizensViewModel>()
            });

            // Students
            // School Citizens
            services.AddSingleton<StudentViewModel>();
            services.AddSingleton<StudentView>(s => new StudentView()
            {
                DataContext = s.GetRequiredService<StudentView>()
            });

            // School Citizens
            // Teachers
            services.AddSingleton<TeacherViewModel>();
            services.AddSingleton<TeacherView>(s => new TeacherView()
            {
                DataContext = s.GetRequiredService<TeacherView>()
            });

            // School Citizens
            // Parents
            services.AddSingleton<ParentViewModel>();
            services.AddSingleton<ParentView>(s => new ParentView()
            {
                DataContext = s.GetRequiredService<ParentView>()
            });

            //School Classes
            services.AddSingleton<SchoolClassesViewModel>();
            services.AddSingleton<SchoolClassesView>(s => new SchoolClassesView()
            {
                DataContext = s.GetRequiredService<SchoolClassesViewModel>()
            });


            //School Subjects
            services.AddSingleton<SchoolSubjectsViewModel>();
            services.AddSingleton<SchoolSubjectsView>(s => new SchoolSubjectsView()
            {
                DataContext = s.GetRequiredService<SchoolSubjectsViewModel>()
            });

            //School Grades
            services.AddSingleton<SchoolGradesViewModel>();
            services.AddSingleton<SchoolGradesView>(s => new SchoolGradesView()
            {
                DataContext = s.GetRequiredService<SchoolGradesViewModel>()
            });

            //School Grades
            //Current lesson
            services.AddSingleton<CurrentLessonViewModel>();
            services.AddSingleton<CurrentLessonView>(s => new CurrentLessonView()
            {
                DataContext = s.GetRequiredService<CurrentLessonViewModel>()
            });

            //School Grades
            //Classes taught
            services.AddSingleton<ClassesTaughtViewModel>();
            services.AddSingleton<ClassesTaughtView>(s => new ClassesTaughtView()
            {
                DataContext = s.GetRequiredService<ClassesTaughtViewModel>()
            });

            //School Grades
            //End of year closing
            services.AddSingleton<EndofYearViewModel>();
            services.AddSingleton<EndofYearView>(s => new EndofYearView()
            {
                DataContext = s.GetRequiredService<EndofYearViewModel>()
            });

            //School Grades
            //End of semester closing
            services.AddSingleton<EndofSemesterViewModel>();
            services.AddSingleton<EndofSemesterView>(s => new EndofSemesterView()
            {
                DataContext = s.GetRequiredService<EndofSemesterViewModel>()
            });


            //Users
            services.AddSingleton<UsersViewModel>();
            services.AddSingleton<UsersView>(s => new UsersView()
            {
                DataContext= s.GetRequiredService<UsersViewModel>()
            });

            //Users
            //Modify
            services.AddSingleton<ModifyUsersViewModel>();
            services.AddSingleton<ModifyUsersView>(s => new ModifyUsersView()
            {
                DataContext = s.GetRequiredService<ModifyUsersViewModel>()
            });

            //Users
            //Delete
            services.AddSingleton<DeleteUsersViewModel>();
            services.AddSingleton<DeleteUsersView>(s => new DeleteUsersView()
            {
                DataContext = s.GetRequiredService<DeleteUsersViewModel>()
            });

            //Users
            //Create
            services.AddSingleton<NewUsersViewModel>();
            services.AddSingleton<NewUsersView>(s => new NewUsersView()
            {
                DataContext = s.GetRequiredService<NewUsersViewModel>()
            });

        }
    }
}
