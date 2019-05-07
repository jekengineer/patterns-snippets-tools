using System;
using System.Collections.Generic;
using System.Linq;

namespace SnippetsBasicDotNetStandard
{
    public class DetermineOppositeD6Face
    {
        // This will determine the opposite D6 face of a d6 in a variety of different ways
        // one way passes just an array of D6 faces seen
        // one way passes just one D6 face
        // TODO: Add Public Interface for Example Usage and Tests


        static int[] possibleVisibleD6Faces = new int[6] { 1, 2, 3, 4, 5, 6 };
        static int[] possibleOppositeD6Faces = new int[6] { 6, 5, 4, 3, 2, 1 };


        protected int[] DetermineOpposingD6Faces(int[] visibleD6Faces)
        {
            int[] oppositeD6Faces = new int[visibleD6Faces.Length];

            for (int i = 0; i < visibleD6Faces.Length; i++) {
                oppositeD6Faces[i] = DetermineOpposingD6Face(visibleD6Faces[i]);
            }

            return oppositeD6Faces;
        }



        protected List<int> DetermineOpposingD6Faces(List<int> visibleD6Faces)
        {
            return DetermineOpposingD6Faces(visibleD6Faces.ToArray()).ToList();
        }



        protected int DetermineOpposingD6Face(int visibleD6Face)
        {
            int oppositeD6Face = 0;

            oppositeD6Face = FindOpposingD6FaceOutOfPossibilities(visibleD6Face);

            return oppositeD6Face;
        }


        protected int FindOpposingD6FaceOutOfPossibilities(int visibleD6Face)
        {

            for (int i = 0; i < possibleVisibleD6Faces.Length; i++) {
                if (visibleD6Face == possibleVisibleD6Faces[i]) {
                    return possibleOppositeD6Faces[i];
                }
            }

            return -1;
        }






    }
}
