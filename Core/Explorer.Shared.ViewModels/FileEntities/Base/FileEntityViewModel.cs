namespace Explorer.Shared.ViewModels
{
    public abstract class FileEntityViewModel : BaseViewModel
    {
        protected FileEntityViewModel(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public string FullName { get; set; }
    }
}