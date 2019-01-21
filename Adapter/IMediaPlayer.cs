namespace Adapter {
    interface IMediaPlayer {
        void play(string filename, IDecoder decoder); // ignore the void
    }
}
