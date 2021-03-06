using System.Collections.Generic;
using Oqtane.Models;

namespace Oqtane.Repository
{
    public interface IFileRepository
    {
        IEnumerable<File> GetFiles(int folderId);
        File AddFile(File file);
        File UpdateFile(File file);
        File GetFile(int fileId);
        File GetFile(int fileId, bool tracking);
        void DeleteFile(int fileId);
        string GetFilePath(int fileId);
        string GetFilePath(File file);
    }
}
