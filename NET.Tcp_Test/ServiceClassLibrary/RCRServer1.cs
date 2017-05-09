using System;
using System.Collections.ObjectModel;
using System.ServiceModel;

namespace ServiceClassLibrary
{
    //interface declarations just like the client but the callback 
    //decleration is a little different
    [ServiceContract]
    public interface IMessageCallback
    {
        [OperationContract(IsOneWay = true)]
        void OnMessageAdded(string message, DateTime timestamp);
    }

    //This is a little different than the client 
    // in that we need to state the SessionMode as required or it will default to "notAllowed"
    [ServiceContract(CallbackContract = typeof(IMessageCallback), SessionMode = SessionMode.Required)]
    public interface IMessage
    {
        [OperationContract]
        void AddMessage(string message);
        [OperationContract]
        bool Subscribe();
        [OperationContract]
        bool Unsubscribe();

        [OperationContract]
        ObservableCollection<string> OnlineUsers();
    }
}
