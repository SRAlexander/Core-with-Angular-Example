namespace RiderMVCTest.DAL.Context
{
    public class DbInitializer
    {
        public static void Initialize(EntityContext context)
        {
            context.Database.EnsureCreated();
            
            // Seed Base DB Data Here
        }
    }
}