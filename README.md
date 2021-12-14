[The original repository](https://github.com/dudinda/Image-Processing)

***

1. [Guide](#Guide)
2. [Demo](#Demo)
   - [WinForms MDI](#WFMDI)
   - [WinForms SDI](#WFSDI)
   - [WinForms TDI](#WFTDI)
   - [WPF SDI](#WPFSDI)
   - [Console](#Console)
***
## Guide

1. Create a presentation layer as a dynamic library. Install the <code>ImageProcessing.Microkernel.EntryPoint</code> from Nuget. Add an implementation of the <code>IStartup</code> interface, create folders for presenters/events/views/viewmodels.
2. Define a new interface for your main view. It should implement the <code>IView</code> interface.
3. Create a new presenter for your main view. Inherit it from the <code>BasePresenter\<TView\></code>. Create a new domain event and subscribe it to the main presenter with the <code>ISubscriber\<TEventArgs\></code> interface.
4. Create an executing assembly. Reference the presentation library. It can be a console, WPF or WinForms project. Add an implementation of the <code>IStartup</code> interface for the UI Layer components. 
5. If necessary, create a base form to handle write/read from another thread or access the aggregator or application controller.
6. Implement the <code>IMainView</code> interface for your main form. In case of WinForms you can use the <code>Aggregator.Unpublish</code> inside the <code>Dispose</code> call. Replace the generated dispose with the <code>new</code> syntax or remove it in the case of a singleton, delegating the disposing call to a DI-container.
7. You can inject the singleton instance of the <code>IEventAggregator</code> into your main form or expose elements to a form event binder component. Bind the defined domain event.
8. Register your main view and its event binder in the <code>UIStartup</code>. You can declare the main view as a singleton to inject it to child views.
9. Inside the Program class use the static state machine to <code>Build\<UIStartup\></code> and <code>Run\<MainPresenter\></code>.
   
## WFMDI

<p align="center">
    <img src="https://i.imgur.com/hdAT5KH.png" width="900" height = "600" alt="application window">
    <p align="center">Fig. 1 - The main MDI - form and child transient forms and the singleton form. The main menu also shows the message from the singleton form.</p>
</p>
</br>  
</br>    

## WFSDI

<p align="center">
    <img src="https://i.imgur.com/2J1FTer.png" width="900" height = "600" alt="application window">
    <p align="center">Fig. 2 - The main form and child SDI transient forms and the singleton form. The main menu also shows the message from the singleton form.</p>
</p>
</br>  
</br>    

## WFTDI

<p align="center">
    <img src="https://i.imgur.com/5vUflqr.png" width="900" height = "600" alt="application window">
    <p align="center">Fig. 3 - The main form and child TDI transient tabs and the singleton tab. The main menu also shows the message from the singleton tab. To close the tab focus the "Send Message" button and press the Del key.</p>
</p>
</br>  
</br>    

## WPFSDI

<p align="center">
    <img src="https://i.imgur.com/CM6zlMS.png" width="900" height = "600" alt="application window">
    <p align="center">Fig. 4 - The main window and child transient windows and the singleton window. The main window also shows the message from the singleton window.</p>
</p>
</br>  
</br>    

## Console

<p align="center">
    <img src="https://i.imgur.com/9Vnekac.png" width="900" height = "500" alt="application window">
    <p align="center">Fig. 5 - The console window is started with the main command and then the singleton command is switched to a foreground thread.</p>
</p>
</br>  
</br>    
