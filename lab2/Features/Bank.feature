Feature: Withdraw Money

  Scenario: Withdraw money from the account
    Given I am on the banking website
    When I select "Login as User" option
    And I select "Hermoine Granger" as a customer
    And I click Login button
    Then I should close Chrome