//
//	Do you like this project? Do you find it helpful? Pay it forward by hiring me as a consultant!
//  https://jason-iverson.com
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JM0ney.Framework.Data;

namespace JM0ney.AssetLibrary.TypeDefinitions.References {

    public interface IRichTextReference : IAssumable<IRichTextReference>, IReference {

        String Value { get; set; }

    }

}
