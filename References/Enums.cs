//
//	Do you like this project? Do you find it helpful? Pay it forward by hiring me as a consultant!
//  https://jason-iverson.com
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM0ney.AssetLibrary.TypeDefinitions.References {

    [Flags]
    public enum VideoFormats : byte {
        StandardManifest = 1,
        MobileManifest = 2,
        Mp4File = 4,
        OgvFile = 8
    }

    public enum AspectRatios : byte {
        FourByThree = 0,
        SixteenByNine = 1
    }

    public enum ContentSources {
        Intranet = 0,
        YouTube = 1
    }


}
