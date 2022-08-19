namespace AsdafObhurRealEstate.Models
{
    public class WhatsAppDataModel
    {
        public string messageing_product { get; set; }

        public string to { get; set; }

        public string type { get; set; }

        public Template template { get; set; }


    }

    public class Language
    {
        public string code { get; set; }

    }


    public class Template
    {
        public string name { get; set; }

        public Language language { get; set; }


        public List<Component> components { get; set; }


    }

    public class Component
    {
        public string type { get; set; }

        public List<Parameter> parameters { get; set; }
    }

    public class Parameter
    {
        public string type { get; set; }
        public string text { get; set; }

    }


    public class Contact
    {
        public string input { get; set; }

        public string wa_id { get; set; }

    }

    public class Message
    {
        public string id { get; set; }

    }

    public class WhatsAppResponse
    {
        public string messaging_product { get; set; }

        public List<Contact> contacts { get; set; }

        public List<Message> messages { get; set; } 
    }
}
