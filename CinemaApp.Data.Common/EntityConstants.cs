namespace CinemaApp.Data.Common
{
    public static class EntityConstants
    {
        public static class Movie
        {
     
            public const int TitleMinLength = 2;

       
            public const int TitleMaxLength = 100;

       
            public const int GenreMinLength = 3;

      
            public const int GenreMaxLength = 50;

        
            public const int DirectorNameMinLength = 2;

     
            public const int DirectorNameMaxLength = 100;

          
            public const int DescriptionMinLength = 10;

         
            public const int DescriptionMaxLength = 1000;

       
            public const int DurationMin = 1;

         
            public const int DurationMax = 300;

         
            public const int ImageUrlMaxLength = 2048;
        }

        public static class Cinema
        {
          
            public const int NameMinLength = 2;

        
            public const int NameMaxLength = 80;

       
            public const int LocationMinLength = 2;

            public const int LocationMaxLength = 50;
        }

        public static class CinemaMovie
        {
            public const int AvailableTicketsDefaultValue = 0;
            public const int ShowtimeMaxLength = 5;
            public const string ShowtimeFormat = "{hh}:{mm}";
        }

        public static class Manager
        {
            public const int EmailMinLength = 5;
        }
    }
}

