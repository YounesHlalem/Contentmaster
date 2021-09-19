using DAL.Configuration;
using DAL.Model;
using DAL.Model.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DAL.Context
{
    public class E4ProgressContext : DbContext
    {
        public DbSet<ContentElementType> ContentElementTypes { get; set; }
        public DbSet<ContentElementTypeTranslation> ContentElementTypeTranslations { get; set; }
        public DbSet<ContentTheme> ContentThemes { get; set; }
        public DbSet<ContentThemeTranslation> ContentThemeTranslations { get; set; }
        public DbSet<CourseModule> CourseModules { get; set; }
        public DbSet<CourseModuleTopicElement> CourseModuleTopicElements { get; set; }
        public DbSet<CourseModuleTopic> CourseModuleTopics { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<DidacticalModelLevel> DidacticalModelLevels { get; set; }
        public DbSet<DidacticalModelLevelTranslation> DidacticalModelLevelTranslations { get; set; }
        public DbSet<DidacticalModel> DidacticalModels { get; set; }
        public DbSet<DidacticalModelTranslation> DidacticalModelTranslations { get; set; }
        public DbSet<DifficultyLevel> DifficultyLevels { get; set; }
        public DbSet<DifficultyLevelTranslation> DifficultyLevelTranslations { get; set; }
        public DbSet<Exercisefile> Exercisefiles { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<LanguageTranslation> LanguageTranslations { get; set; }
        public DbSet<OfficeApplication> OfficeApplications { get; set; }
        public DbSet<QuestionAnswer> QuestionAnswers { get; set; }
        public DbSet<QuestionContentTheme> QuestionContentThemes { get; set; }
        public DbSet<QuestionExercisefile> QuestionExercisefiles { get; set; }
        public DbSet<QuestionFormulationType> QuestionFormulationTypes { get; set; }
        public DbSet<QuestionFormulationTypeTranslation> QuestionFormulationTypeTranslations { get; set; }
        public DbSet<QuestionLearninggoal> QuestionLearninggoals { get; set; }
        public DbSet<QuestionPreKnowledgeSkill> QuestionPreKnowledgeSkills { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionsHistory> QuestionsHistory { get; set; }
        public DbSet<Questiontype> Questiontypes { get; set; }
        public DbSet<QuestiontypeTranslation> QuestiontypeTranslations { get; set; }
        public DbSet<QuizQuestionAnswer> QuizQuestionAnswers { get; set; }
        public DbSet<QuizQuestion> QuizQuestions { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleTranslation> RoleTranslations { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<User> Users { get; set; }


        public E4ProgressContext() : base() { }
        public E4ProgressContext(DbContextOptions<E4ProgressContext> options) : base(options)
        {

        }


        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();

            var markedAsDeleted = ChangeTracker.Entries().Where(x => x.State == EntityState.Deleted);

            foreach (var item in markedAsDeleted)
            {
                if (item.Entity is IIsDeleted entity)
                {
                    item.State = EntityState.Unchanged;
                    entity.IsDeleted = true;
                }
            }
            return base.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContentElementTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ContentElementTypeTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new ContentThemeConfiguration());
            modelBuilder.ApplyConfiguration(new ContentThemeTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new CourseModuleConfiguration());
            modelBuilder.ApplyConfiguration(new CourseModuleTopicConfiguration());
            modelBuilder.ApplyConfiguration(new CourseModuleTopicElementConfiguration());
            modelBuilder.ApplyConfiguration(new DidacticalModelConfiguration());

            modelBuilder.ApplyConfiguration(new DidacticalModelLevelConfiguration());
            modelBuilder.ApplyConfiguration(new DidacticalModelLevelTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new DidacticalModelTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new DifficultyLevelConfiguration());
            modelBuilder.ApplyConfiguration(new DifficultyLevelTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new ExerciseFileConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new OfficeApplicationConfiguration());

            modelBuilder.ApplyConfiguration(new QuestionAnswerConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionContentThemeConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionExercisefileConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionFormulationTypeConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionFormulationTypeTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionLearninggoalConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionPreKnowledgeSkillConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionsHistoryConfiguration());

            modelBuilder.ApplyConfiguration(new QuestiontypeConfiguration());
            modelBuilder.ApplyConfiguration(new QuestiontypeTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new QuizConfiguration());
            modelBuilder.ApplyConfiguration(new QuizQuestionConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new RoleTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());

            modelBuilder.ApplyConfiguration(new QuizQuestionAnswerConfiguration());

            base.OnModelCreating(modelBuilder);
        }


    }
}
