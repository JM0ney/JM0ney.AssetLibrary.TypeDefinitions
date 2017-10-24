using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM0ney.AssetLibrary.TypeDefinitions.References {

    public interface IQuizSection : Data.IAssumable<IQuizSection> {

        Guid QuizReferenceIdentity { get; set; }

        SequencingOptions Sequencing { get; set; }

        byte CandidateCount { get; set; }

    }

}
