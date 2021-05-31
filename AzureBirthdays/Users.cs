using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureBirthdays {

  //-------------------------------------------------------------------------------------------------------------------
  //
  /// <summary>
  /// Nedra User
  /// </summary>
  //
  //-------------------------------------------------------------------------------------------------------------------

  public sealed class NedraUser {
    #region Private Data

    #endregion Private Data

    #region Algorithm

    internal async Task Enrich() {
      var user = await AzureClient.Client.Users[ID]
        .Request()
        .Select("Department,Birthday")
        .GetAsync();

      Department = user.Department;
      BirthDay = (user.Birthday ?? new DateTimeOffset(new DateTime(1, 1, 1))).DateTime;
    }

    #endregion Algorithm

    #region Create

    internal NedraUser(string id, string name, string jobTitle, string eMail) {
      ID = id;
      FullName = name;
      JobTitle = jobTitle;
      EMail = eMail;
    }

    #endregion Create

    #region Public

    public string ID { get; private set; }

    public string FullName { get; private set; }

    public DateTime BirthDay { get; private set; }

    public string Department { get; private set; }

    public string JobTitle { get; private set; }

    public string EMail { get; private set; }

    #endregion Public
  }

  //-------------------------------------------------------------------------------------------------------------------
  //
  /// <summary>
  /// Nedra Users
  /// </summary>
  //
  //-------------------------------------------------------------------------------------------------------------------

  public sealed class NedraUsers {
    #region Private Data

    /// <summary>
    /// Nedra Users
    /// </summary>
    private List<NedraUser> m_Items = new List<NedraUser>();

    #endregion Private Data

    #region Algorithm

    private async Task CoreLoad() {
      if (m_Items.Count > 0)
        return;

      var items = await AzureClient
        .Client
        .Users
        .Request()
        .Top(999)
        .GetAsync();

      foreach (var item in items) {
        NedraUser user = new NedraUser(
          item.Id, 
          item.DisplayName,
          item.JobTitle,
          item.Mail);

        //await user.Enrich(); // !!!!

        m_Items.Add(user);
      }
    }

    #endregion Algorithm

    #region Create

    // Standard constructor
    private NedraUsers() { }

    /// <summary>
    /// Create
    /// </summary>
    public static async Task<NedraUsers> Create() {
      var result = new NedraUsers();

      await result.CoreLoad();

      return result;
    }

    #endregion Create

    #region Public

    /// <summary>
    /// 
    /// </summary>
    public IReadOnlyList<NedraUser> Items => m_Items;

    #endregion Public
  }

}
