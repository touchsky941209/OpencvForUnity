using System;

namespace OpenCVForUnity.CoreModule
{

    //C++: class DMatch

    /**
     * Structure for matching: query descriptor index, train descriptor index, train
     * image index and distance between descriptors.
     */
    public partial class DMatch
    {

        //
        #region Operators

        // (here D stand for a dmatch ( DMatch ).)

        #region Comparison
        // D < D
        public static bool operator <(DMatch d1, DMatch d2)
        {
            return d1.distance < d2.distance;
        }

        // D > D
        public static bool operator >(DMatch d1, DMatch d2)
        {
            return d1.distance > d2.distance;
        }
        #endregion

        #endregion
        //

    }
}

