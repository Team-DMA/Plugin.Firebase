﻿using Plugin.Firebase.Common;
using Plugin.Firebase.iOS.Firestore;
using FBFirestore = Firebase.CloudFirestore.Firestore;

namespace Plugin.Firebase.Firestore
{
    public sealed class FirebaseFirestoreImplementation : DisposableBase, IFirebaseFirestore
    {
        private readonly FBFirestore _firestore;
        
        public FirebaseFirestoreImplementation()
        {
            _firestore = FBFirestore.SharedInstance;
        }

        public ICollectionReference GetCollection(string collectionPath)
        {
            return new CollectionReferenceWrapper(_firestore.GetCollection(collectionPath));
        }
        
        public IDocumentReference GetDocument(string documentPath)
        {
            return new DocumentReferenceWrapper(_firestore.GetDocument(documentPath));
        }
    }
}