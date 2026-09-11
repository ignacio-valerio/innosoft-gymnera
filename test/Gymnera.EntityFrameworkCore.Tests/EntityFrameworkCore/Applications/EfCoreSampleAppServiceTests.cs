using Gymnera.Samples;
using Xunit;

namespace Gymnera.EntityFrameworkCore.Applications;

[Collection(GymneraTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<GymneraEntityFrameworkCoreTestModule>
{

}
