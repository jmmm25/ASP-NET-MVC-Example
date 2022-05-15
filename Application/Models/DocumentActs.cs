using Application.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application.Models
{
    public class DocumentActs
    {
        public List<Document> GetDocuments()
        {
            DocumentData documentData = new DocumentData();
            var documents = documentData.Documents;

            return documents;
        }
    }
}