Import-Module ActiveDirectory
New-ADOrginizationalUnit "IS399" -path "OU=Norwich,OU=Classrooms,DC=nucacdf,DC=org"
New-ADOrginizationalUnit "Students" -path "OU=IS399,OU=Norwich,OU=Classrooms,DC=nucacdf,DC=org"
New-ADGroup -name "IS399 -groupscope Global -path "OU=IS399,OU=Norwich,OU=Classrooms,DC=nucacdf,DC=org"
New-ADUser -Name BenJones -Path "OU=Students,OU=IS399,OU=Norwich,OU=Classrooms,DC=nucacdf,DC=org"  -UserPrincipalName BJones -AccountPassword(ConvertTo-SecureString 1*Changeme -AsPlainText -Force) -ChangePasswordAtLogon $true -Enabled $true -EmailAddress bjones5 -accountExpirationDate "8/20/2015 12:00:00 AM -GivenName Ben -Surname Jones
Add-ADGroupMember "IS399" BJones;
New-ADUser -Name RachelLittle -Path "OU=Students,OU=IS399,OU=Norwich,OU=Classrooms,DC=nucacdf,DC=org"  -UserPrincipalName RLittle -AccountPassword(ConvertTo-SecureString 1*Changeme -AsPlainText -Force) -ChangePasswordAtLogon $true -Enabled $true -EmailAddress rlittle@ -accountExpirationDate "8/20/2015 12:00:00 AM -GivenName Rachel -Surname Little
Add-ADGroupMember "IS399" RLittle;
