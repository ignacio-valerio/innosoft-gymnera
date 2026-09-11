using Xunit;

namespace Gymnera.EntityFrameworkCore;

[CollectionDefinition(GymneraTestConsts.CollectionDefinitionName)]
public class GymneraEntityFrameworkCoreCollection : ICollectionFixture<GymneraEntityFrameworkCoreFixture>
{

}
