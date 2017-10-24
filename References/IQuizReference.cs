using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM0ney.AssetLibrary.TypeDefinitions.References {

    public interface IQuizReference : Data.IAssumable<IQuizReference>, IReference {

        References.SequencingOptions Sequencing { get; set; }

    }

}
