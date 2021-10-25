using isa3.Data.Others;
using System.Linq;

namespace isa3.Infra {
    public static class DbInitializer {
        public static void Initialize(ApplicationDbContext context) {
            if (context.TrainingData.Any()) {
                return;   // DB has been seeded
            }

            var trainingdata = new TrainingData[]
            {
                new()
               {
                   Name = "HIIT", Description = "Intensiivne 60min", LocationOfTraining = "Tallinn",
                   AvailableEquipment = "kk",

               },

            };

            context.TrainingData.AddRange(trainingdata);
            context.SaveChanges();
        }
    }
}
