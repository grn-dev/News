using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.Domain.Entity
{
    public enum EnmTypeFile {
        video=1,
        Audio=2,
        image=3,
        document=4,

    }

    public enum EnuContentType {
        news=1,
        article=2,
        ImageGalleri=3,
        Video=4
        ///36:06
    }
    public enum enmCommebtStatuse {
        New=1,
        Accept=2,
        Reject=3
    }

}
