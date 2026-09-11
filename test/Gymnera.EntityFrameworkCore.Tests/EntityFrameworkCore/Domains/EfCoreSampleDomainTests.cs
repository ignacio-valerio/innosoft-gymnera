using Gymnera.Samples;
using Xunit;

namespace Gymnera.EntityFrameworkCore.Domains;

[Collection(GymneraTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<GymneraEntityFrameworkCoreTestModule>
{

}
