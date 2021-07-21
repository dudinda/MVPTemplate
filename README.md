# MVP Template using the Microkernel

<p>The original repository https://github.com/dudinda/Image-Processing.</p>

<p align="center">
    <img src="https://i.imgur.com/9d7KTBB.png" width="900" height = "600" alt="application window">
    <p align="center">Fig. 1 - The main MDI - form and child transient forms and the singleton form. The main menu also shows the message from the singleton form.</p>
</p>
</br>  
</br>    
<p align="center">
    <img src="https://i.imgur.com/mKz937U.png" width="900" height = "600" alt="application window">
    <p align="center">Fig. 2 - The main window and child transient windows and the singleton window. The main window also shows the message from the singleton window.</p>
</p>
</br>  
</br>    
<p align="center">
    <img src="https://i.imgur.com/aPJppc0.png" width="900" height = "500" alt="application window">
    <p align="center">Fig. 3 - The console window is started with the main command and then the singleton command is switched to a foreground thread. By default, there is no synchronization context and the event aggregator sets it to SynchronizationContext with the continuation on the thread pool. To continue on the original thread a synchronization context with the blocking queue may be introduced and set up.</p>
</p>

