# EFCore.ModelBuilderExtensions

A library for entensions to Entity Framework Core for model building.

Currently this only includes setting default values for SQL databases.

## Install

This package is available for install on [Nuget](https://www.nuget.org/packages/EFCore.ModelBuilderExtensions/).

### Nuget Package Manager
```
Install-Package EFCore.ModelBuilderExtensions -Version 1.0.0
```

### .NET CLI
```
dotnet add package EFCore.ModelBuilderExtensions --version 1.0.0
```

## Usage
### SQL Default Values

In the model context, use the SetSQLDefaultValues() extension method inside the ```OnModelCreating``` method.
```
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.SetSQLDefaultValues();
}
```

Add the ```SqlDefaultValue``` attribute in the EFCore.ModelBuilderExtensions.Attributes namespace on an Entity Framework model class.

```
public class ExampleClass
{
    [SqlDefaultValue("Hello World")]
    public string ClassProperty { get; set; }

    [SqlDefaultValue("getdate()")]
    public DateTime DateProperty { get; set; }
}
```

Now you're set!

Use the standard ```Add-Migration``` command in the package manager console. If you go to the migration that is built you will notice the ```defaultValueSql``` property is set against the column definition.
