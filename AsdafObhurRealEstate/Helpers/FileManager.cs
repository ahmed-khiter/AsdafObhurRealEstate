namespace AsdafObhurRealEstate.Helpers
{
    public class FileManager
    {

        private readonly IWebHostEnvironment env;
        private string folder;

        public FileManager(IWebHostEnvironment env)
        {
            this.env = env;
            folder = "uploads";
        }

        public string Upload(IFormFile file)
        {
            string extension = Path.GetExtension(file.FileName);


            string fileName = GenerateName(extension);
            string uploadPath = GetDestination(fileName);

            using (var fileStream = new FileStream(uploadPath, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            return fileName;
        }

        public List<string> Upload(List<IFormFile> files)
        {
            List<string> model = new List<string>();
            for (int i = 0; i < files.Count; i++)
            {
                string extension = Path.GetExtension(files[i].FileName);

        

                string fileName = GenerateName(extension);
                string uploadPath = GetDestination(fileName);

                using (var fileStream = new FileStream(uploadPath, FileMode.Create))
                {
                    files[i].CopyTo(fileStream);
                }

                model.Add(fileName);
            }
            return model;
        }

        public bool Delete(string file)
        {
            if (string.IsNullOrEmpty(file))
            {
                return false;
            }

            try
            {
                string fullPath = GetDestination(file);
                File.Delete(fullPath);
            }
            catch (IOException exception)
            {
                Console.WriteLine("FILE MANAGER ERROR:: " + exception.Message);
            }

            return true;
        }
        
        private string GenerateName(string extension)
        {
            return DateTime.Now.Ticks.ToString() + extension;
        }

        private string GetDestination(string file)
        {
            return Path.Combine(env.WebRootPath, folder, file);
        }

    }
}
