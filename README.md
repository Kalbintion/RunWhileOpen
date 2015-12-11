# RunWhileOpen
Application targeted at Steam to run with specified file running.

From Module1.vb

    This application will stay running in the background until a program is no longer opened
      which was to allow a "game" to be marked as being played in steam without having to worry
      about the overlay potentially coming up due to some software not being intended to work
      with steams overlays or other steam interactions

    Particular use cases involve Minecraft's Map Editor MCEdit, where multiple versions use the
      same executable name, but swapping between them would require each particular version to be
      added to the Steam library list. Sony Vegas Pro 13.0 has crashed with Steam overlay attempting
      to be added to the application.

# Usage
RunWhileOpen [exe]

# Steam Usage
Add non-steam game
Right-Click RunWhileOpen
Properties
Re-name to what you want to display
Modify Target line and append the executable name to look for without the .exe portion