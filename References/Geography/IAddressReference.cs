//
//  Do you like this project? Do you find it helpful? Pay it forward by hiring me as a consultant!
//  https://jason-iverson.com
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JM0ney.Framework.Data;

namespace JM0ney.AssetLibrary.TypeDefinitions.References.Geography {
    public interface IAddressReference : IAssumable<IAddressReference>, IReference {

        //Guid? GeoPointReferenceIdentity { get; set; }

        IGeoPointReference GeoPoint { get; }

        String Line1 { get; set; }

        String Line2 { get; set; }

        String City { get; set; }

        String StateOrProvince { get; set; }

        String PostalCode { get; set; }

    }
}
