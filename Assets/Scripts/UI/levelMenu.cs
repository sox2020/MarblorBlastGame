using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

[CreateAssetMenu(fileName="level", menuName="Menu/LevelMenu")]
public class LevelMenu : ScriptableObject  {

  public Scene Level;
  public string Name;
  public int levelId;
  public Difficulty difficulty;
  public Image image;

  public enum Difficulty { Easy, Medium, Hard, ExtraHard, LitterallyImpossible }

}
