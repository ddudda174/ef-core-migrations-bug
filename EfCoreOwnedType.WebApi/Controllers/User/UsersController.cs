namespace EfCoreOwnedType.WebApi.Controllers.User
{
    using Base;
    using Data.DataSources;

    public class UsersController : BaseV1Controller
    {
        private readonly UserStore _userStore;

        public UsersController(UserStore userStore)
        {
            _userStore = userStore;
        }

        //[HttpGet("")]
        //public async Task<IEnumerable<UserDto>> LoadAllAsync(int offset = 0, int count = 10)
        //{
        //    return await _userStore.LoadAsync(offset, count).ConvertAll(ConvertUserToDto);
        //}
    }
}
