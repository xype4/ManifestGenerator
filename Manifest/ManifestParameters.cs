using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manifest
{
    internal class ManifestParameters
    {
        public int MaxDuration { get; }
        public int MaxMark { get; }
        public int PassMark { get; }
        public string Mode { get; }
        public int SceneNumber { get; }
        public string LearningMode{ get;}

        public ManifestParameters(int maxDuration, int maxMark, int passMark, string mode, int sceneNumber, string learningMode)
        {
            MaxDuration = maxDuration;
            MaxMark = maxMark;
            PassMark = passMark;
            Mode = mode;
            SceneNumber = sceneNumber;
            LearningMode = learningMode;
        }
    }
}
