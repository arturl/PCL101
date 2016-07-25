# Copyright (c) Microsoft. All rights reserved.
# Licensed under the MIT license. See LICENSE file in the project root for full license information.

if (-Not (Test-Path 'NuGet.exe')) {
    # this gets the latest nuget.exe version (currently 3.3)
    Invoke-WebRequest 'https://dist.nuget.org/win-x86-commandline/latest/nuget.exe' -OutFile 'NuGet.exe' 
}

$v1 = "1.0.0"

$id='Awesome.PCL101'

echo "Creating NuGet package $id version $v1"

.\NuGet.exe pack "$id.nuspec" -Prop Configuration=Release -Prop id=$id -Prop Version=$v1

