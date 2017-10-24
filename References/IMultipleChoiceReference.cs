using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JM0ney.Framework.Data;

namespace JM0ney.AssetLibrary.TypeDefinitions.References {

    public interface IMultipleChoiceReference : IAssumable<IMultipleChoiceReference>, IReference {

        bool IsMutuallyExclusive { get; set; }

        byte MaximumNumberOfTries { get; set; }

        Guid AudioIdentity { get; set; }

        IAudioReference Audio { get; }

        Guid QuestionIdentity { get; set; }

        IRichTextReference Question { get; }



        IEnumerable<IMultipleChoiceInputOption> InputOptions { get; }

        void SetInputOptions( IEnumerable<IMultipleChoiceInputOption> inputOptions );
    }

}
