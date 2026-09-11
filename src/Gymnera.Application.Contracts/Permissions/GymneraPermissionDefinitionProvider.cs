using Gymnera.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Gymnera.Permissions;

public class GymneraPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(GymneraPermissions.GroupName);

        var booksPermission = myGroup.AddPermission(GymneraPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(GymneraPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(GymneraPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(GymneraPermissions.Books.Delete, L("Permission:Books.Delete"));

        var authorsPermission = myGroup.AddPermission(GymneraPermissions.Authors.Default, L("Permission:Authors"));
        authorsPermission.AddChild(GymneraPermissions.Authors.Create, L("Permission:Authors.Create"));
        authorsPermission.AddChild(GymneraPermissions.Authors.Edit, L("Permission:Authors.Edit"));
        authorsPermission.AddChild(GymneraPermissions.Authors.Delete, L("Permission:Authors.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(GymneraPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<GymneraResource>(name);
    }
}
