using System;

namespace SquareDMS_DataAccessLayer.Entities
{
    public class DocumentVersion : IEntity
    {
        public DocumentVersion(int docId, DateTime eventDateTime,
            int versionNr, int fileFormatId, Guid guid, byte[] fileStreamData)
        {
            DocumentId = docId;
            EventDateTime = eventDateTime;
            VersionNr = versionNr;
            FileFormatId = fileFormatId;
            Guid = guid;
            FilestreamData = fileStreamData;
        }

        public DocumentVersion() { }

        public int Id { get; private set; }

        public int DocumentId { get; private set; }

        public DateTime EventDateTime { get; private set; }

        public int VersionNr { get; private set; }

        public int FileFormatId { get; private set; }

        public Guid Guid { get; private set; }

        public byte[] FilestreamData { get; private set; }
    }
}
