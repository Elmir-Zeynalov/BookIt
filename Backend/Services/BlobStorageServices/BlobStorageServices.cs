

using System.Runtime.InteropServices;
using Azure.Storage.Blobs;

namespace Backend.Services.BlobStorageServices
{
    public class BlobStorageServices : IBlobStorageService
    {
        private readonly string _connectionString;
        private readonly string _containerName;

        public BlobStorageServices(IConfiguration configuration)
        {
            _connectionString = configuration["AzureBlobStorage:ConnectionString"]!;
            _containerName = configuration["AzureBlobStorage:ContainerName"]!;
        }

        public Task DeleteBlobAsync(string blobName, string containerName)
        {
            throw new NotImplementedException();
        }

        public Task DeleteContainerAsync(string containerName)
        {
            throw new NotImplementedException();
        }

        public Task<Stream> GetBlobAsync(string blobName, string containerName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ListBlobsAsync(string containerName)
        {
            throw new NotImplementedException();
        }

        public Task<string> UploadFileBlobAsync(string filePath, string containerName)
        {
            throw new NotImplementedException();
        }

        public Task<string> UploadFileBlobAsync(Stream stream, string containerName)
        {
            throw new NotImplementedException();
        }

        public async Task<string> UploadImageAsync(IFormFile file)
        {
            var blobServiceClient = new BlobServiceClient(_connectionString);
            var containerClient = blobServiceClient.GetBlobContainerClient(_containerName);

            // Ensure the container exists
            await containerClient.CreateIfNotExistsAsync();

            string blobName = Guid.NewGuid() + Path.GetExtension(file.FileName);
            var blobClient = containerClient.GetBlobClient(blobName);

            using var stream = file.OpenReadStream();
            await blobClient.UploadAsync(stream, overwrite: true);

            return blobClient.Uri.ToString();
        }
    }
}
