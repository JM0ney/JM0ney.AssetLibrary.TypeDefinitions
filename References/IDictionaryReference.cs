using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM0ney.AssetLibrary.TypeDefinitions.References {

    public interface IDictionaryReference : Data.IAssumable<IDictionaryReference>, IReference {

        String WordOrPhrase { get; set; }
        String Definition { get; set; }
        Guid? AudioIdentity { get; set; }
        Guid? ImageIdentity { get; set; }

    }

}
