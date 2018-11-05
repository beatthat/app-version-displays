Displays the app version on a text component of arbitrary type.

## Install

From your unity project folder:

    npm init
    npm install beatthat/app-version-displays --save

## Usage

Create a GameObject with a ```Unity.UI.Text``` component and then add an instance of ```AppVersionText``` to the same GameObject.

To use with TextMeshPro, you will need the ```BeatThat.Properties``` wrappers for TextMeshPro also installed in your Unity project, e.g.

```
npm install --save beatthat/property-bindings-text-mesh-pro
```

**NOTE**: ```beatthat/propery-bindings``` pulls in a bunch of additional dependencies on install, but you're probably not using this component unless you're already using other beat that packages.

## Development

You can edit the code and samples in the test environment and then use ```npm run test-install``` to sync changes back to the package src.

```
    npm run test-install
    cd test

    # edit code under Assets/Plugins/packages/{package.scope}/{package.name}
    # edit samples under Assets/Samples/packages/{package.scope}/{package.name}

    # sync changes back to src
    npm run test-overwrite2src
```

**REMEMBER:** changes made under the test folder are not saved to the package
unless they are copied back into the source folder
