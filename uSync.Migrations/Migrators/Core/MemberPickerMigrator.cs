﻿namespace uSync.Migrations.Migrators.Core;

[SyncMigrator(UmbConstants.PropertyEditors.Aliases.MemberPicker, IsDefaultAlias = true)]
[SyncMigrator("Umbraco.MemberPicker2")]
public class MemberPickerMigrator : SyncPropertyMigratorBase
{ }
