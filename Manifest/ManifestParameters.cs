using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        public string getJson()
        {
            string jsonOut = "{\n";

            jsonOut += getJsonLine(nameof(MaxDuration), MaxDuration, false);
            jsonOut += getJsonLine(nameof(MaxMark), MaxMark, false);
            jsonOut += getJsonLine(nameof(PassMark), PassMark, false);
            jsonOut += getJsonLine(nameof(Mode), Mode, false);
            jsonOut += getJsonLine(nameof(SceneNumber), SceneNumber, false);
            jsonOut += getJsonLine(nameof(LearningMode), LearningMode, true);

            jsonOut += "}";

            return jsonOut;
        }

        private string getJsonLine(string name, int parametr, bool last) 
        {
            string output = "\t\"" + name + "\": " + parametr.ToString();
            if (last)
                output += "\n";
            else
                output += ",\n";
            return output;
        }

        private string getJsonLine(string name, string parametr, bool last)
        {
            string output = "\t\"" + name + "\": \"" + parametr.ToString() + "\"";
            if (last)
                output += "\n";
            else
                output += ",\n";
            return output;
        }
    }
}
