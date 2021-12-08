# Force to create a zip file 
$ZipFile = "APIs.zip"
New-Item $ZipFile -ItemType File -Force
 
$RepositoryZipUrl = "https://github.com/temenos/APIs/archive/master.zip"
# download the zip 
Write-Host 'Starting downloading the GitHub Repository'
Invoke-RestMethod -Uri $RepositoryZipUrl -OutFile $ZipFile
Write-Host 'Download finished'
 
#Extract Zip File
Write-Host 'Starting unzipping the GitHub Repository locally'
Expand-Archive -Path $ZipFile -DestinationPath . -Force
Write-Host 'Unzip finished'
     
# remove the zip filerectory.Parent.FullName }
#Remove-Item -Path $ZipFile -Force
#Remove-Item -Path "archive" -Force
#Remove-Item -Path ".gitignore" -Force
#Remove-Item -Path "README.md" -Force