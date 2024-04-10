using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Indexers
{
    public  class DocumentCollection
    {
        private List<Document> documents = new List<Document>();

        // Indexer to get or set documents
        public Document this[int index]
        {
            get { return documents[index]; }
            set { documents[index] = value; }
        }

        // Method to add a document to the collection
        public void AddDocument(Document doc)
        {
            documents.Add(doc);
        }

    }
}
