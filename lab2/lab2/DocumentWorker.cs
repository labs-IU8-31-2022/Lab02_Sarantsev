using System;
namespace lab2
{
    public class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Pro");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Pro");
        }
    }

    public class ProDocumentWorker: DocumentWorker
    {
        private int key_ = 987654321;
        public virtual void CheckKey(int key)
        {
            if (key_ == key)
            {
                Console.WriteLine("Access for the ProDocumentWorker is allowed");
            }
        }
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
        }
    }

    public class ExpertDocumentWorker: ProDocumentWorker
    {
        private int key_ = 126789356;
        public override void CheckKey(int key)
        {
            if (key_ == key)
            {
                Console.WriteLine("Access for the ExpertDocumentWorker is allowed");
            }
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}

