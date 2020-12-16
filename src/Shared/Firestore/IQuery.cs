using System;
using System.Threading.Tasks;

namespace Plugin.Firebase.Firestore
{
    public interface IQuery
    {
        IQuery WhereEqualsTo(string field, object value);
        IQuery WhereGreaterThan(string field, object value);
        IQuery WhereLessThan(string field, object value);
        IQuery WhereGreaterThanOrEqualsTo(string field, object value);
        IQuery WhereLessThanOrEqualsTo(string field, object value);
        IQuery OrderBy(string field);
        IQuery StartingAt(params object[] fieldValues);
        IQuery StartingAt(IDocumentSnapshot snapshot);
        IQuery StartingAfter(params object[] fieldValues);
        IQuery StartingAfter(IDocumentSnapshot snapshot);
        IQuery EndingAt(params object[] fieldValues);
        IQuery EndingAt(IDocumentSnapshot snapshot);
        IQuery EndingBefore(params object[] fieldValues);
        IQuery EndingBefore(IDocumentSnapshot snapshot);
        IQuery LimitedTo(int limit);
        IQuery LimitedToLast(int limit);
        
        Task<IQuerySnapshot<T>> GetDocumentsAsync<T>();
        IDisposable AddSnapshotListener<T>(Action<IQuerySnapshot<T>> onChanged, Action<Exception> onError = null, bool includeMetaDataChanges = false);
    }
}