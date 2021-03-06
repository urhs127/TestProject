param (
    [Parameter(Mandatory=$false)]
    [String]$SOLUTION,
    [Parameter(Mandatory=$false)]
    [String]$BUILDPROFILE,
    [Parameter(Mandatory=$false)]
    [String]$SOURCE,
    [Parameter(Mandatory=$false)]
    [String]$DESTINATION,
    [Parameter(Mandatory=$false)]
    [String]$PACKAGE
)


& msbuild $SOLUTION /p:DeployOnBuild=true /p:PublishProfile=$BUILDPROFILE

& msdeploy -verb:sync -source:iisApp="$SOURCE" -dest:package="$PACKAGE"

& msdeploy -verb:sync -source:package="$PACKAGE" -dest:iisApp="$DESTINATION" -allowUntrusted=true

