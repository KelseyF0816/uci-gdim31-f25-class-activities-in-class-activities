# in-class-activities
## Devlogs
### W1
When the Camera is no longer a child of the Cat, it stops following the cat as it moves and turns. This is because the Camera no longer moves with the Cat's Transform.

Itch.io game link: https://sleepsleepforever.itch.io/w1-class-activity

### W2
1. The r, g, and b variables are floats because color values use decimals between 0 and 1, like 0.3. Ints only store whole numbers, bools store true or false, and strings store text.

2. The _bounces variable is an int because it counts whole bounces, like 1, 2, and 3. It does not need decimals, true or false values, or text.

3. The error in Step 4 is "; expected." This means the line is missing a semicolon at the end. The correct code is `g -= 0.1f;`.

### W3
#### Activity1 (Table#8): 
1. string GetResponse(int friendshipLevel, bool knowsSecret)
2. void SetLightDimness(float sanityLevel)
3. bool DidPlayerHitBeat(float pressTime)

#### Activity2：
A class is like a blueprint, and a Component is something built from it. Member variables describe its traits, while methods define what it can do.

#### Activity3: 
The balls get extremely bright because their color values keep increasing every time they bounce, eventually going beyond the normal range.

### W4 
Table(#10)
1. I added Rigidbodies to the Cat and SoccerBall so the cat could kick the ball and both could respond to physics. I checked Is Trigger on the Goal so the ball could pass through it and register a goal, while leaving it unchecked on the Cat and SoccerBall so they could physically collide.

2. When I first tested the game, the cat tilted and rotated unexpectedly while moving, which also tilted the camera attached to it. I froze the Rigidbody’s X and Z rotation, and the issue was resolved.

### W6
1. A serialized Transform _target and a NavMeshAgent _agent.
2. Unity’s built-in Start() method.
3. Start() should get the NavMeshAgent using GetComponent<NavMeshAgent>(), then call _agent.SetDestination(_target.position) to make the deer walk toward its target.

## W7
google doc: https://docs.google.com/document/d/151SgXqNHDRftL5pOKSRbTrPD8LsiZ29sz2fVIOB1WiY/edit?usp=sharing
My category assignment: General C# coding
Notes:
1. The class needed a float for the bat’s speed and a Transform for its target. The speed can be adjusted in the Inspector.
2. The class needed Unity’s Update() method and two custom public methods, StartChasing() and StopChasing().
3. StartChasing() sets the cat as the target, and StopChasing() clears it. Update() moves the bat toward the target each frame while it has one.


## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 

