using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestWCFCustomer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICustomer
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "customers/")]
        List<Customer> GetCustomers();

        [OperationContract]
        [WebInvoke(Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "customers/{id}")]
        String GetCustomer(int id);

        [OperationContract]
        [WebInvoke(Method = "DELETE",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json,
          UriTemplate = "customers/{id}")]
        void DeleteCustomer(int id);


        [OperationContract]
        [WebInvoke(Method = "CREATE",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json,
          UriTemplate = "customers/{c}/{id}")]
        void CreateCustomer(Customer c);


        [OperationContract]
        [WebInvoke(Method = "PUT",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json,
          UriTemplate = "customers/{c}/{id}")]
        void UpdateCustomer(Customer c, int id);


    }
}
