
namespace UsersAndAwards.DAL.Dependencies
{
    public static class UsersAndAwardsDALDependencies
    {
        private static IAwardDAO _awardDAO;

        private static IUserDAO _userDAO;

        public static IAwardDAO AwardDAO => _awardDAO ?? (_awardDAO = new AwardDAO());

        public static IUserDAO UserDAO => _userDAO ?? (_userDAO = new UserDAO());

        public static void SaveUserInfo()
        {
            UserDAO.SaveUserStorage();
        }

        public static void SaveAwardInfo()
        {
            AwardDAO.SaveAwardStorage();
        }

        public static void SaveAwardToUserInfo()
        {
            AwardDAO.SaveAwardToUserStorage();
        }

    }
}
