using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestsPlayModeTests
    {
        [UnityTest]
        [Timeout(180000)] // Sets the timeout of the test in milliseconds (if the test hangs, this will ensure it closes after 3 minutes).
        public IEnumerator TestMovementScriptPresent()
        {

            //copied from: https://www.dima.to/blog/?p=499
            // Remove the default skybox.
            RenderSettings.skybox = null;
            // Create a new root game object.
            var root = new GameObject();
            // Attach a camera to our root game object.
            root.AddComponent(typeof(Camera));
            // Get a reference to the camera.
            var camera = root.GetComponent<Camera>();
            // Set the camera's background color to white.
            camera.backgroundColor = Color.white;
            // Add our game object (with the camera included) to the scene by instantiating it.
            root = GameObject.Instantiate(root);
            // Load a prefab (by giving it the path to an existing prefab).
            var prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Resources/prefabs/Player.prefab");
            // Instantiate the prefab (by adding it to the scene). Use the Quaternion to set the rotation 
            // in degrees and the Vector3 to set the position in 3D space.
            prefab = GameObject.Instantiate(prefab, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
            // Wait for three seconds (this gives us time to see the prefab in the scene if its an animation or something else).
            yield return new WaitForSeconds(3f);
            // In this example, let's assume that our Example.prefab has a script on it called ExampleScript.
            var script = prefab.gameObject.GetComponentInChildren<MovementPlayer>();
            // Assert that the script exists on our prefab so we don't stumble upon this problem in the future.
            Assert.IsTrue(script != null, "ExampleScript must be set on Example.prefab.");
            // Finally, we should clean up our scene by destroying our objects.
            GameObject.Destroy(prefab);
            GameObject.Destroy(root);
        }

        [UnityTest]
        [Timeout(180000)] // Sets the timeout of the test in milliseconds (if the test hangs, this will ensure it closes after 3 minutes).
        public IEnumerator TestIfPlayerCanMove()
        {

            //copied from: https://www.dima.to/blog/?p=499
            // Remove the default skybox.
            RenderSettings.skybox = null;
            // Create a new root game object.
            var root = new GameObject();
            // Attach a camera to our root game object.
            root.AddComponent(typeof(Camera));
            // Get a reference to the camera.
            var camera = root.GetComponent<Camera>();
            // Set the camera's background color to white.
            camera.backgroundColor = Color.white;
            // Add our game object (with the camera included) to the scene by instantiating it.
            root = GameObject.Instantiate(root);
            // Load a prefab (by giving it the path to an existing prefab).
            var prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Resources/prefabs/Player.prefab");
            // Instantiate the prefab (by adding it to the scene). Use the Quaternion to set the rotation 
            // in degrees and the Vector3 to set the position in 3D space.
            prefab = GameObject.Instantiate(prefab, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
            // Wait for three seconds (this gives us time to see the prefab in the scene if its an animation or something else).
            yield return new WaitForSeconds(3f);
            // In this example, let's assume that our Example.prefab has a script on it called ExampleScript.
            var script = prefab.gameObject.GetComponentInChildren<MovementPlayer>();
            // Assert if the target is moving or not when instantiated
            Assert.IsTrue(script.playerIsMoving == false, "Player is moving without input, player cannot move because it thinks it is moving");
            // Finally, we should clean up our scene by destroying our objects.
            GameObject.Destroy(prefab);
            GameObject.Destroy(root);
        }

        [UnityTest]
        [Timeout(180000)] // Sets the timeout of the test in milliseconds (if the test hangs, this will ensure it closes after 3 minutes).
        public IEnumerator TestIfPlayerIsClamped()
        {

            //copied from: https://www.dima.to/blog/?p=499
            // Remove the default skybox.
            RenderSettings.skybox = null;
            // Create a new root game object.
            var root = new GameObject();
            // Attach a camera to our root game object.
            root.AddComponent(typeof(Camera));
            // Get a reference to the camera.
            var camera = root.GetComponent<Camera>();
            // Set the camera's background color to white.
            camera.backgroundColor = Color.white;
            // Add our game object (with the camera included) to the scene by instantiating it.
            root = GameObject.Instantiate(root);
            // Load a prefab (by giving it the path to an existing prefab).
            var prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Resources/prefabs/Player.prefab");
            // Instantiate the prefab (by adding it to the scene). Use the Quaternion to set the rotation 
            // in degrees and the Vector3 to set the position in 3D space.
            prefab = GameObject.Instantiate(prefab, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
            // Wait for three seconds (this gives us time to see the prefab in the scene if its an animation or something else).
            yield return new WaitForSeconds(3f);
            // In this example, let's assume that our Example.prefab has a script on it called ExampleScript.
            var script = prefab.gameObject.GetComponentInChildren<MovementPlayer>();
            // Assert if the target is moving or not when instantiated
            Assert.IsTrue(script.playerIsClamped == true, "Player is not clamped!!");
            // Finally, we should clean up our scene by destroying our objects.
            GameObject.Destroy(prefab);
            GameObject.Destroy(root);
        }

        // A Test behaves as an ordinary method
        [Test]
        public void TestsPlayModeTestsSimplePasses()
        {
            // Use the Assert class to test conditions
            Assert.IsTrue(true);
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestsPlayModeTestsWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            Assert.IsTrue(true);

            yield return null;
        }
    }
}
