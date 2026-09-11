using Gymnera.Books;
using Xunit;

namespace Gymnera.EntityFrameworkCore.Applications.Books;

[Collection(GymneraTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<GymneraEntityFrameworkCoreTestModule>
{

}