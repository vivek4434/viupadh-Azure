CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse("StorageAccountConnectionString");
CloudBlobClient cloudBlobClient = cloudStorageAccount.CreateCloudBlobClient();
CloudBlobContainer  cloudBlobContainer = cloudBlobClient.GetContainerReference("BlobContainerName");
//cloudBlobContainer.CreateIfNotExistsAsync();


var blobName = $"{"DirectoryName"}/{Guid.NewGuid()}";
CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(blobName);
cloudBlockBlob.UploadTextAsync("Files Containing Data inside Directory");

var _blobName = $"{"DirectoryName"}/{"SubDirectoryName"}/{"FileNameThatYouWishToStore"}";
cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(_blobName);
cloudBlockBlob.UploadTextAsync("Files containing data inside sub-directory");