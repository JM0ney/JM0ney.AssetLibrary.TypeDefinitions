using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JM0ney.Framework.Data;

namespace JM0ney.AssetLibrary.TypeDefinitions.References {

    public interface IMultipleChoiceInputOption : IAssumable<IMultipleChoiceInputOption> {

        Guid MultipleChoiceReferenceIdentity { get; set; }

        Guid ImageIdentity { get; set; }

        IImageReference Image { get; }

        Guid RichTextIdentity { get; set; }

        IRichTextReference RichText { get; }

        bool IsCorrect { get; set; }
        byte Number { get; set; }

    }

}
