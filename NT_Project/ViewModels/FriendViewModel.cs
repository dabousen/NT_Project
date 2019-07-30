using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NT_Project.ViewModels
{
    public class FriendViewModel
    {
      
            public string Title { get; set; }
            public string FirstId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Id { get; set; }
            public int? Type { get; set; }
    }
    public class FriendViewCompare : IEqualityComparer<FriendViewModel>
    {
        public bool Equals(FriendViewModel x, FriendViewModel y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode(FriendViewModel obj)
        {
            throw new NotImplementedException();
        }
    }
}
