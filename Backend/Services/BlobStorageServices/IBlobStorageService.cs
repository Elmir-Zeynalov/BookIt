namespace Backend.Services.BlobStorageServices
{
    public interface IBlobStorageService
    {
        Task<string> UploadFileBlobAsync(string filePath, string containerName);
        Task<string> UploadFileBlobAsync(Stream stream, string containerName);
        Task DeleteBlobAsync(string blobName, string containerName);
        Task DeleteContainerAsync(string containerName);
        Task<IEnumerable<string>> ListBlobsAsync(string containerName);
        Task<Stream> GetBlobAsync(string blobName, string containerName);
    }
}
