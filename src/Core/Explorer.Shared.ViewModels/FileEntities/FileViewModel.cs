using Explorer.Shared.ViewModels.FileEntities.Base;

namespace Explorer.Shared.ViewModels.FileEntities
{
    public sealed class FileViewModel : FileEntityViewModel
    {
        public FileViewModel(string name) : base(name)
        {
        }

        public FileViewModel(FileInfo fileInfo) : base(fileInfo.Name)
        {
            FullName = fileInfo.FullName;
        }
    }
}
