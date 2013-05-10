using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PromotionalFoil
{
    class ClassVideo
    {
        private readonly string _sPath;
        private readonly int _iDuration;
        private readonly ClassGlobal.Position _posPosition;

        public ClassVideo(string sPath, int iDuration, ClassGlobal.Position posPosition)
        {
            _sPath = sPath;
            _iDuration = iDuration;
            _posPosition = posPosition;
        }
        
        public string Path{get{return _sPath;}}
        public int Duration { get { return _iDuration; } }
        public ClassGlobal.Position Position { get { return _posPosition; } }
    }
}
